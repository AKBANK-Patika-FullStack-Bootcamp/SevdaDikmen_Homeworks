//dog ve dogCareUtility import ediliyor
const dog = require("./dog");
const dogCare = require("./dogCareUtility");

console.log("Köpek adı: "+dog.name);
console.log("Köpek boyu: "+dog.size+"cm");
dogCare.cleanDog();
console.log("Köpek ilgi saati: "+dog.weight*dogCare.dogCareHour);