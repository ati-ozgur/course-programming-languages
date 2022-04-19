function repeat_decorator(fn)
{
    decorated_fn = function()
    {
        fn()
        fn()
    }
    // returns a function
    return decorated_fn
}
 
function hello_world()
{
    console.log("Hello world!")
}
 
hello_world_twice = repeat_decorator(hello_world)
 
// call the function
hello_world_twice()