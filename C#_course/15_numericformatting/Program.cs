


double value = 1000D / 12.34D;

System.Console.WriteLine(value);
System.Console.WriteLine(string.Format("{0: 0}", value)); //will round it up (but wont affect the actual value of the var )
System.Console.WriteLine(string.Format("{0: 0.0}", value));
System.Console.WriteLine(string.Format("{0: 0.00}", value));


double money = -10D / 3D;
System.Console.WriteLine(money);

System.Console.WriteLine(string.Format(" -10 $ / 3 $ =  {0:0.00} $ ", money));
                                                    //tzv PATTERN - nevadí něco před a zad
System.Console.WriteLine(money.ToString("C"));
System.Console.WriteLine(money.ToString("C0"));
System.Console.WriteLine(money.ToString("C1"));
System.Console.WriteLine(money.ToString("C2"));


Console.ReadLine();