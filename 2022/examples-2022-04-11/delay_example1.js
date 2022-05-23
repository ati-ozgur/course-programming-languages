

function x()
{
    console.log("x is called");
}


function example1(a, callback_func)
{
    setTimeout(callback_func , 3000);
}

console.log("before calling example1");
example1(5, x);
console.log("after calling example1");


