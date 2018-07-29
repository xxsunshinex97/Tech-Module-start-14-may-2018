function symmetric(arr){
    let end = Number(arr[0]);
    for(let i = 1; i <= end; i++){
        if (isSymmetric("" + i)) {
            console.log((i));
        }
    }
    function isSymmetric(num){
        for(let i = 0; i < num.length; i++){
            if (num[i] != num[num.length - 1 - i]) {
                return false;
            }
        }
        return true;
    }
}