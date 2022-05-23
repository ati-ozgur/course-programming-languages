


function example1(a, callback)
{
    setTimeout(callback , 3000);
}

console.log("before calling example1");

example1(5, function(){
    console.log("x is called");
}
 )


console.log("after calling example1");


