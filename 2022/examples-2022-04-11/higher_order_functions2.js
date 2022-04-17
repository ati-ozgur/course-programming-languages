let addTo = function(x)
{
    let add = function(y)
    {
        return x+ y;
    }

    return add;
}

add2 = addTo(2);

add10 = addTo(10);

const x1 = add2(5);
console.log(x);

const x2 = add10(5);
console.log(x2);