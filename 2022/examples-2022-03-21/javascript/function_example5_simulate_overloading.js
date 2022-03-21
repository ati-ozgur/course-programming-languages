function hello(name,country)
{
	if (country !== undefined)
	{
		if (name !== undefined)
		{
			console.log("hello, " + name + " from " + country)
		}
		else
		{
			console.log("hello, Unknown person" + " from " + country )

		}

	}else if (name !== undefined)
	{

		console.log("Hello " + name)
	}
	else
	{

		console.log("Hello Unknown Person")
	}

}

hello("Atilla","Germany")
hello()
hello("Duru", "Turkiye")

hello("Duru")

