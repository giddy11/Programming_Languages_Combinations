"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
/*The syntax (a: string) => void means “a function with one parameter, named a, of type string, that doesn’t have a return value”. Just like with function declarations, if a parameter type isn’t specified, it’s implicitly any. */
function greeter(fn) {
    fn("Hello, World");
}
function printToConsole(s) {
    console.log(s);
}
function greeter1(fn) {
    console.log("hi");
}
greeter(printToConsole);
