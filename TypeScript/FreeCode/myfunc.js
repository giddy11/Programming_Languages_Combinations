"use strict";
/*Wrong way */
// function addTwo(num: number){
//     return "hello"
// }
Object.defineProperty(exports, "__esModule", { value: true });
/*Right way */
function addTwo(num) {
    return num + 2;
}
/*We can also have more than 1 return statement */
// function getVal(myVal: number): boolean{
//     if (myVal > 5) {
//         return true
//     }
//     return "200 OK"
// }
/*Error Functions */
var getHello = function (s) {
    return "";
};
var heros = ["thor", "spiderman"];
heros.map(function (hero) {
    return "hero is ".concat(hero);
});
var myVal = addTwo(5);
