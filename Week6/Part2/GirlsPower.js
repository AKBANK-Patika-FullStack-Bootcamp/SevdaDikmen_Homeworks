let arr = [2,3,4];

//Verilen her bir sayıyı kendisinin yarısıyla toplayıp 3 ekleyip sayıyı dönen işlem.
let girlsPowerSum=number=>{
    number+=(number/2)+3;
    return number;
}

//Verilen arrayin her bir elemanına girlsPowerSum işlemini uygulayıp tekrar array olarak dönen fonksiyon.
function girlsPowerFunc(...arr){
    let arr2;
    arr.forEach(element=>{arr2=arr.map(element => girlsPowerSum(element))});
    return arr2;
}
console.log("Array: ",arr);
console.log("Girls Power: ",girlsPowerFunc(...arr));