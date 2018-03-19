//Programma Calcolo Temperatura 
//Alternanza 
typedef struct
{
  float res; 
  int tem;
}STemp;

STemp tab[11] = {
  {31.77 , 0},
  {19.68 , 10},
  {12.47 , 20},
  {8.06 , 30},
  {5.32 , 40},
  {3.59 , 50},
  {2.47 , 60},
  {1.73 , 70},
  {1.24 , 80},
  {0.90 , 90},
  {0.67 , 100},
};

float temp;
int val_tens;


void setup() 
{
 // put your setup code here, to run once:
}

void loop() 
{
 val_tens = analogRead(A1);
  
 //temp = ((val_Adc * 0.00488) - 0.5) / 0.01;
 
  // put your main code here, to run repeatedly:

}
