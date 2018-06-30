var Person = /** @class */ (function () {
    function Person() {
    }
    Person.prototype.walk = function () {
        return this.name + " is walking";
    };
    return Person;
}());
var person1 = new Person();
person1.name = "Raul";
person1.gender = "Male";
var person2 = new Person();
person2.name = "Petra";
person2.gender = "Female";
console.log(person1.name);
console.log(person1.walk());
console.log(person2.name);
