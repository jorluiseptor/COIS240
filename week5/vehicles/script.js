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
    Vehicle.prototype.describe = function () {
        console.log("My " + this.type + " has " + this.numWheels + " wheels!.");
    };
    return Vehicle;
}());
var Car = /** @class */ (function (_super) {
    __extends(Car, _super);
    function Car() {
        var _this = _super.call(this) || this;
        _this.type = "Car"; //automaticallly set the type property to Car
        return _this;
    }
    Car.prototype.refillGas = function () {
        console.log("The gas tank is full");
    };
    return Car;
}(Vehicle));
var v1 = new Vehicle();
v1.type = "Car";
v1.numWheels = 4;
v1.describe();
var v2 = new Vehicle();
v2.numWheels = 2;
v2.type = "Bycicle";
v2.describe();
var c1 = new Car();
c1.model = "Toyota";
console.log("My " + c1.type + " is a " + c1.model + ".");
c1.refillGas();
