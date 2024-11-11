//Storing typing (static and dynamic)
let a = 87;
let b: string ="This is for string";
let c: number = 45;
let d: number = 65;
console.log(a,b,c,d);

//this is for function
function add(a:number, b:number): number {
   return a+b;
}
console.log(add(5,5));

//array
let arr: number[] = [34, 123, 12, 12, 3];
let array: Array<any> = [5, "a", 54, "hello"];
let tuple: [number, string] = [5, 'aa'];
console.log(arr, array, tuple);

enum Level {
    Low,
    Medium,
    High
};
console.log(Level);
console.log(Level.Medium);