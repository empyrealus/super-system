/*
  study1 consolidate
*/
using System;
using System.Collections.Generic;
abstract class prototypes
{
    public abstract void do_ternary2<T>(ref T param);
    public abstract string do_ternary(string x);
}
class Program<TXM> : prototypes
{
	public TXM testingFunc<TXD>(TXM? value, TXD? param1){
	  if(typeof(TXM) != null && param1 != null && typeof(TXD) != null){return value;}
	   Program<string> x = new Program<string>();
	   x.testingFunc<string>(null, null); 
	   return value;
       }
       public TXM test { get => test; set{test =  testingFunc<string>(value, "string");}}
       public void displayData(TXM data){
		 Console.WriteLine(this.test);
       }
       public override string do_ternary(string okay){
	  return "String";
       }
       public override void do_ternary2<T>(ref T test){}
	
       public static void Main(){
		Program<string> superProgram = new Program<string>();
	}
}
