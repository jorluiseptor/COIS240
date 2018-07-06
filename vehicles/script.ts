class Vehicle {
    type: string;
    numWheels: number; 
}

class Car extends Vehicle {
    model: string; 
    refillFuel():void{
        console.log(`${this.model} car is getting more fuel`);
    }
    describeCar():string {
        return `This car is a ${this.model} and has ${this.numWheels} wheels`;
    }
}

let myCar1 = new Car();
myCar1.model = "Toyota";
myCar1.numWheels=4; 
myCar1.refillFuel();
console.log(myCar1.describeCar());