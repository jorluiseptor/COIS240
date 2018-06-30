
class Person {
    name: string;
    gender:string; 
    walk(): string {
        return `${this.name} is walking`;
    }       
}

let person1 = new Person();
person1.name = "Raul";
person1.gender = "Male";

let person2 = new Person();
person2.name = "Petra";
person2.gender = "Female";

console.log(person1.name);
console.log(person1.walk());
console.log(person2.name);