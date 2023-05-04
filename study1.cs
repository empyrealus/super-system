/*
  This program contains no programmatic errors but has not been tested, therfore, results may vary.
  This code is mostly for studying purposes.
*/
using System;
using System.Collections.Generic;
			
// Create prototypes
abstract class prototypes
{
    public abstract void do_ternary2<T>(ref T param); // function will accept any type assigned with 1 param
	public abstract string do_ternary(string x); // function will accept strings only with 1 param
}

class Program<TXM> : prototypes // assign abstract prototypes to a generic class
{
	/* methods can reserve their own Generic type aside from the public specified type to ensure that a publically called method can not be executed using the wrong type
       the reserved method generic type that is defined privately, allows us to enforce a generic type for specific use-cases bypassing is-else, ternary, switch, etc.
	   
	   TXM and TXD may be null using "?"
	   TXD? param1 may be null null = 1 logically (See. De Morgans Law)
	   */
	public TXM testingFunc<TXD>(TXM? value, TXD? param1){
		    // Check for absent type on generic TXM type using string based null because typeof returns string type as output
		    // further, using "?" we allow null to become a valid type to check against, instead of a pure string based isNull pragma (directive)
			 if(typeof(TXM) != null && param1 != null && typeof(TXD) != null){
			  // value exists and is not of a null type
				 Console.WriteLine(value + " test 1");
			    return value;
			 }
			 // Requires a generic value to be returned, to ensure* we get a null value we re-instance the class, call the function using null, null, on null type accepting generics and return the value (which should be null)
		     Program<string> x = new Program<string>();
		     x.testingFunc<string>(null, null); //force set value to null on class rebuild with null value, result should return value = null of type null which should deduce to = 1 (true) -- logically not programmaticall
			 Console.WriteLine(value + " test 2");
		     return value;
			}
			void newTest(){}
			
	 // you can not get 'this' because it looks for a type that is not yet defined,
	 // but instead you can get self, like below (untested)
     public TXM test { get => test; set{test =  testingFunc<string>(value, "string");}}
	
	 public void displayData(TXM data)
	 {
		 Console.WriteLine(this.test);
	 }
	 
	 // implement a basic func with params
	 public override string do_ternary(string okay){
	  //what this does is allows me to override the implementaiton of an abstract, not override the pre-defined type
	  return "String";
	 }
    
	//implement a generic
	public override void do_ternary2<T>(ref T test){
	  //return 2;
	 }
			

	 public void construct()
	 {
	 }
	
	public static void Main()
	{
		Program<string> superProgram = new Program<string>();
	    Console.WriteLine(superProgram.test); //not done.... work-in-progress
	}
}
