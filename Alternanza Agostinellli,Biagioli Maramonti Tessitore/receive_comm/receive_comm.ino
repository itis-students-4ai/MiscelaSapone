

typedef unsigned short ushort;

// protocollo
#define P_LEN  2	// posizione del len bye nel pacchetto
#define P_DATA 3	// posizione del payload nel pacchetto
// caratteri di controllo
#define STX 0xA5
#define ACK 0x5A
// packet types


// tipi di pacchetto SET
#define  SET_MODE	0x01	// modalità del sistema 0: stop; 1: on;
#define  SET_TEMP	0x02	// tempeatura
#define  SET_MOT	0x03	// movimentazione
#define  SET_TIME	0x04	// movimentazione

// tipi di pacchetto GET
#define GET_TEMP	0x12	// richiesta temperatura
#define GET_ERR		0x15	// richiesta eventuali errori

#define LED	13


byte n_byte = 0;

byte in_buf[16];
byte in_idx = 0;
byte in_len;
byte in_chk;
byte pack_ready;

byte out_buf[16];
byte out_idx = 0;
byte out_len;

byte ch;
byte led_stat = 0;

enum E_IOStat
{
	RX,
	TX,
};
byte IOStat = RX;

enum EInStat
{
	WAIT_STX,
	RECEIVE,
	READY,
};

EInStat stat = WAIT_STX;

// -----------------------------------------
// Dati del progetto
//
ushort T_SET = 0;		// temperatura impostata in decimi do grado
ushort T_CUR = 0; 		// temperatuta corrente in decimo di grado		 




// prepara il pacchetto temperatura
void MakeTempRes(void);
// calcola il checksum su un buffer
byte Check(byte buf[], byte len);

void setup() 
{
  // put your setup code here, to run once:
  Serial.begin(38400);
  pinMode(LED, OUTPUT);     
  pack_ready = 0;
}

void loop() 
{
	
	// Input / Output da seriale
	switch ( IOStat )
	{
		case RX:
		
			if (!Serial.available())
				break;
				
			ch = Serial.read();
			
			// segnala ricezione
			led_stat = !led_stat;
			digitalWrite(LED, led_stat);
			
			// analizza carattere
			switch (stat)
			{
				case WAIT_STX:
			
					if ( ch == STX )
					{
						  in_idx = 0;
						  in_len = 0xFF;
						  in_buf[in_idx++] = ch;
						  stat = RECEIVE;
						  in_chk = STX;
					}
					break;
			
			  case RECEIVE:
			     
			     if ( in_idx == 2 )
			     {
				       in_len = ch + 3;			// 
				       in_buf[in_idx++] = ch;
				       in_chk += ch;
				       break;
			     } 
			
			     if ( in_idx == in_len )
			     {
			          if ( in_chk == ch )
			          {
			              pack_ready = 1;
			              stat = READY;
			          }
			          else
			          {
			          	  stat = WAIT_STX;
			          }
			          break;
			     }
			
			     in_buf[in_idx++] = ch;
			     in_chk += ch;
				 break;
			}
			break;

		case TX:
			Serial.write(out_buf, out_len);
			IOStat = RX;
			stat = WAIT_STX;
			break;
			
	}
	
	// arrivato un pacchetto?
	if (pack_ready)
	{
		pack_ready = 0;

		Serial.write(ACK);
		
		// elabora il pacchetto;
		switch ( in_buf[1] )
		{
			case SET_TEMP:
			
				T_SET = in_buf[3] * 0x100 + in_buf[4];
				T_CUR = T_SET;
				// .... 
				// altre cose da fare
				stat = WAIT_STX;
				break;

			case GET_TEMP:
				MakeTempRes();
				IOStat = TX;
				break;
		}
	}

}

// prepara il pacchetto temperatura
void MakeTempRes(void)
{
	byte chk;
	out_buf[0] = STX;
	out_buf[1] = GET_TEMP;
	out_buf[2] = 2;
	out_buf[3] = T_CUR >> 8;
	out_buf[4] = T_CUR;
	chk = Check(out_buf, 5);
	out_buf[5] = chk;
	out_len = 6;
}


// calcola il checksum su un buffer
byte Check(byte buf[], byte len)
{
	byte chk = 0;
	byte i;
	for (i=0; i<len; i++)
		chk += buf[i];
	return chk;

}
