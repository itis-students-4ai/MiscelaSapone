// Pin per il controllo dei motorini
int Pin0 = 10;
int Pin1 = 11;
int Pin2 = 12;
int Pin3 = 13;

int ValoreMaxTemp = da impostare;
//int ValoreMaxVel = 100%;
int NumStepGiroMotore = 4096;
// Numero step per 1 rotazione al minuto
int NumStepRPMs;

/*// Scelta del motorino su cui agire, 1 o 2
char Scelta;*/

boolean dir = true;

// Settaggio dei pin in uscita
void setup()
{
  pinMode(Pin0, OUTPUT);
  pinMode(Pin1, OUTPUT);
  pinMode(Pin2, OUTPUT);
  pinMode(Pin3, OUTPUT);
}

void loop()
{
  // Scelta fornita dal programma Visual Studio 
  switch(Scelta)
  {
    // Agitatore
    case '1':
      // Si settano i giri/minuto (RotationPerMinutes) desiderati
      // Ottenuti dal programma Visual Studio
      setSpeed(RPMs);
      break;

    // Temperatura
    case '2':
      LeggiTemperatura();
      // Calcola differenza temp_letta e temp_desiderata
      // Aumenta/cala RPMs a seconda del valore ( positivo/negativo ) della diff.
      Temperatura(VALORETEMPERATURA);
      break;
  }
}



/*void Temperatura(float ValoreTemp)
{
  for(int i = 0; i < (ValoreTemp * NumStepGrado); i++)
    digitalWrite(Pin_motorino_temperatura, HIGH);     // Impulso
}*/

/*digitalWrite(Pin0, LOW);
digitalWrite(Pin1, LOW);
digitalWrite(Pin2, HIGH);
digitalWrite(Pin3, HIGH);*/
      
/*if(dir)
    _step++;
  
  else
    _step--;
  
  if(_step>7)
    _step=0;
  
  if(_step<0)
    _step=7;
  
  delay(1);
}*/

if( f_mot == 1) // f_mot = flag motore
{
  f_mot = 0;

  // codice per operatori motore
  
}

if(f_temp == 1) // f_temp = flag temperatura
{
  


}

int t_read = millis();
#define PER_LETT 5000

bop
{
  if ( millis() - t_read >= PER_LETT)
  {
    t_read = millis();
    // azioni per leggere
    f_read = 1;
  }
  
}

small_stepper.setSpeed(300);
Steps2Take = 0248;
small_stepper.step(Steps2Take);
delay(2000);
small_stepper.setSpeed(300);
Steps2Take = - 2048;
small_stepper.step(Steps2Take);



