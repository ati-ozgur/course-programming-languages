function repeat(fn,n_times = 2)
{
    decorated_fn = function()
    {
        for (let index = 0; index < n_times; index++) {
            fn()            
        }
    }
    // returns a function
    return decorated_fn
}
 
function hello_world()
{
    console.log("Hello world!")
}
 
hello_world_5 = repeat(hello_world,5)
 
// call the function
hello_world_5()