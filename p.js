//Storing typing (static and dynamic)
var a = 87;
var b = "This is for string";
var c = 45;
var d = 65;
console.log(a, b, c, d);
//this is for function
function add(a, b) {
    return a + b;
}
console.log(add(5, 5));
//array
var arr = [34, 123, 12, 12, 3];
var array = [5, "a", 54, "hello"];
var tuple = [5, 'aa'];
console.log(arr, array, tuple);
var Level;
(function (Level) {
    Level[Level["Low"] = 0] = "Low";
    Level[Level["Medium"] = 1] = "Medium";
    Level[Level["High"] = 2] = "High";
})(Level || (Level = {}));
;
console.log(Level);
console.log(Level.Medium);
