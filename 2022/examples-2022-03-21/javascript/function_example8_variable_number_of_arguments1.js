function hello()
{
	for(let i=0;i<arguments.length; i++)
	{
		console.log("Hello " + arguments[i])
	}
	if (arguments.length === 0)
	{
		console.log("Hello Unknown Person")
	}
}

hello()
hello("Atilla","Deneme","Duru")
