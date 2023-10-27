// Function Type Expressions
function greeter(fn: (a: string) => void) {
    fn("Hello, World");
  }
   
  function printToConsole(s: string) {
    console.log(s);
  }

type GreetFunc = (a: string) => void;
function greeter1(fn: GreetFunc){
    console.log("hi")
}

greeter(printToConsole);

//Call Signatures
type DescribableFunc = {
    description: string;
    (someArg: number): boolean;
};
function doSomething(fn: DescribableFunc){
    console.log(`${fn.description} returned ${fn(6)}`)
}

function myFunc(someArg: number){
    return someArg > 3;
}
myFunc.description = "default description";

doSomething(myFunc);

// never
function fail(msg: string): never {
    throw new Error(msg);
  }

function fn(x: string | number) {
    if (typeof x === "string") {
    // do something
    } else if (typeof x === "number") {
    // do something else
    } else {
    x; // has type 'never'!
    }
}



export{}