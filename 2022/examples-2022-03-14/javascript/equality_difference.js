let a = "1"
let b = 1

console.log(typeof(a))
console.log(typeof(b))

if (a == b){
    console.log("a equals to b");
}
else
{
    console.log("a NOT equals to b since == does not consider the type");
}

if (a === b){
    console.log("a equals to b");
}
else
{
    console.log("a NOT equals to b since === does not consider the type");
}