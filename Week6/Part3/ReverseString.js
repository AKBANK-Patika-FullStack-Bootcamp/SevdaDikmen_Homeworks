//String metodları olan split,reverse ve join kullanılarak verilen string tersten yazdırılıyor.
function reverseString1(str){
    return str.split("").reverse().join("");  
}

//For döngüsüyle, verilen stringin elemanları sondan başlanarak yeni bir stringe dönüştürülüp yazdırılıyor.
function reverseString2(str){
    let str2="";
    for (var i = str.length-1; i >= 0; i--)
        str2+=str[i]
    return str2;
}

//Rekürsif fonksiyonla string tersine çevriliyor.
function reverseString3(str) {
    if (str === "")
        return "";
    else
        return reverseString3(str.substr(1)) + str.charAt(0);
  }

  console.log(reverseString1("sevda"));
  console.log(reverseString2("sevda"));
  console.log(reverseString3("sevda"));