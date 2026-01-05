
//const 

const int vat = 20;

const double percentVAT = vat / 100D; //ITLL GIVE US THE VAT FROM NUMBER FORM TO DECIMAL FORM 

// dostaneme error protože CONST INT zakazuje změnu -> vat = 10;
 //můžeme změnit variable

int balance = 222988698;


System.Console.WriteLine($"the % of VAT is {percentVAT} %");
System.Console.WriteLine(balance * (vat/100D)); //CHCEME DOUBLE - DECIMAL NUM
System.Console.WriteLine(balance * percentVAT);


const string version = "v1.0 yo mama";



System.Console.ReadLine();