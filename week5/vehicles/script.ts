class Vehicle {
    type: string;
    numWheels: number;
    describe():void{
        console.log(`My ${this.type} has ${this.numWheels} wheels!.`);
    }
}

class Car extends Vehicle {
    model: string; 

    constructor(){
        super(); //super means that it is superceding the parent class (Vehicle)
        this.type= "Car"; //automaticallly set the type property to Car
    }

    refillGas(){
        console.log("The gas tank is full"); 
    }
}


let v1 = new Vehicle();
v1.type = "Car";
v1.numWheels = 4;
v1.describe();

let v2 = new Vehicle();
v2.numWheels = 2;
v2.type = "Bycicle"; 
v2.describe();

let c1 = new Car();
c1.model = "Toyota";
console.log(c1.model + " " + c1.type); 
console.log(`My ${c1.type} is a ${c1.model}.`); 
c1.refillGas(); 