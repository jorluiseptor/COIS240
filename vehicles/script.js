var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var Vehicle = /** @class */ (function () {
    function Vehicle() {
    }
    return Vehicle;
}());
var Car = /** @class */ (function (_super) {
    __extends(Car, _super);
    function Car() {
        return _super !== null && _super.apply(this, arguments) || this;
    }
    Car.prototype.refillFuel = function () {
        console.log(this.model + " car is getting more fuel");
    };
    Car.prototype.describeCar = function () {
        return "This car is a " + this.model + " and has " + this.numWheels + " wheels";
    };
    return Car;
}(Vehicle));
var myCar1 = new Car();
myCar1.model = "Toyota";
myCar1.numWheels = 4;
myCar1.refillFuel();
console.log(myCar1.describeCar());
