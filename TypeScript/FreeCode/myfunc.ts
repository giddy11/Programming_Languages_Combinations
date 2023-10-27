/*Wrong way */
// function addTwo(num: number){
//     return "hello"
// }

/*Right way */
function addTwo(num: number): number{
    return num + 2 
}

/*We can also have more than 1 return statement */
// function getVal(myVal: number): boolean{
//     if (myVal > 5) {
//         return true
//     }
//     return "200 OK"
// }

/*Error Functions */
const getHello = (s: string):string => {
    return ""
}

/*Wrong way */
function consoleError1(errmsg: string){
    console.log(errmsg);
}

/*Right */
function consoleError(errmsg: string): void{
    console.log(errmsg);
}

const heros = ["thor", "spiderman"]
heros.map((hero): string => {
    return `hero is ${hero}`
})


let myVal = addTwo(5)




export{}