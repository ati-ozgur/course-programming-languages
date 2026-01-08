class HeapQuiz {
    deger = 0;
}

let x = 0;
let dizi = new Array(5);
while (x < 3){
    dizi[x] = new HeapQuiz();
    dizi[x].deger = x;
    x = x + 1;
}

dizi[3] = dizi[1];
dizi[4] = dizi[1];
dizi[3] = null;
dizi[4] = dizi[0];
dizi[0] = null;
dizi[3] = dizi[2];
dizi[2] = null;


console.log(dizi);
