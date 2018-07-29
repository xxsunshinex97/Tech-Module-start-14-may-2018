/*function ThreeNumsInteger(arr) {

    let nums = arr[0].split(' ').map(Number);
    console.log(
        check(nums[0], nums[1], nums[2]) ||
        check(nums[0], nums[2], nums[1]) ||
        check(nums[1], nums[2], nums[0]) || 'No')


    function check(num1, num2, sum) {
        if (num1 + num2 != sum)
            return false;
        if (num1 > num2)
            [num1, num2] = [num2, num1];
        return `${num1} + ${num2} = ${sum}`;
    }
}*/

function ThreeNumsInteger([num1], [num2], [num3]) {

    num1 = Number(num1);
    num2 = Number(num2);
    num3 = Number(num3);


    function check(num1, num2, num3) {
        if (num1 + num2 === num3) {
            if (num1 > num2) {
                [num1, num2] = [num2, num1];
            }
            console.log(`${num1} + ${num2} = ${num3}`);
        }
        else if (num1 + num3 === num2) {
            if (num1 > num3) {
                [num1, num3] = [num3, num1];
            }
            console.log(`${num1} + ${num3} = ${num2}`);
        }
        else if (num2 + num3 === num1) {
            if (num2 > num3) {
                [num2, num23] = [num3, num2];
            }
            console.log(`${num2} + ${num3} = ${num1}`);
        }
        else {
            console.log('No')
        }
    }
    }