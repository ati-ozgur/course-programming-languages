function hello(...names)
{
	for(let i=0;i<names.length; i++)
	{
		console.log("Hello " + names[i])
	}
	if (names.length === 0)
	{
		console.log("Hello Unknown Person")
	}
}

hello()
hello("Atilla","Deneme","Duru")

hello("Atilla","Deneme","Duru","","Funda")
