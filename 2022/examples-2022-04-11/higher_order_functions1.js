function addition(x,y)
{
    return x + y;
}

function subtraction(x,y)
{
    return x - y;
}

function division(x,y)
{
    return x / y;
}
function multiplication(x,y)
{
    return x * y;
}

function arithmetics(x,y,z, op1,op2)
{
    val1 = op1(x,y);
    val2 = op2(val1,z);
    return val2;
}

a = arithmetics(1,2,3, addition,multiplication);
console.log(a);