console.log("Hello from Node Hello World!")

// for (let i=0; i<=10; i++) {
//     console.log(`Printing the number ${i}`)
// }

// // set timeout 
// var timeout = 3000; // 3 seconds
// setTimeout(() => {
//     console.log(`Hello after ${timeout} seconds`)
// }, timeout)

// // set interval
// var interval = 1000; // 1 second
// setInterval(() => { // set interval
//     console.log(`Calm down`) // print calm down
// }, interval); // every 1 second

// var interval = 1000;
// var counter = 0;

// dothis = () => {
//     console.log(`elegates are confusing ${counter}`)
//     if (counter >= 10) clearInterval(mySleep)
//     counter++;
// }

// var mySleep = setInterval(dothis, interval);

console.log("Array Handling!")
const myArray = [10, 20, 30]
console.log(myArray)

console.log("\nAdded items to array")
myArray.push(40)
myArray.push(50)
console.log(myArray)

console.log("\n Popped from array")
myArray.pop();
console.log(myArray)

