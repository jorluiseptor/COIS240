
function Calculate():void {


    let dog: any = {
        name:document.getElementById("dog-name").value,
        breed:document.getElementById("dog-breed").value,
        years:5,
        bark: function(){
            return "woof, woof!";
        }
    };

    document.getElementById("output").innerHTML = `Tengo un perro que se llama ${dog.name}. Es un ${dog.breed} y tiene ${dog.years} años.`;
    
}