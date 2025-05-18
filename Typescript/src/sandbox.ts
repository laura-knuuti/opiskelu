//explicit types
/*let merkki: string;
let ika: number;
let isLoggedIn: boolean;

ika = 30;
isLoggedIn= true;*/

//arrays
/*
let nimet = ['taika', 'tintti', 'pyry', 'halla'];
nimet.push('kissat');

let numerot = [10, 20, 30, 40];
numerot.push(11);

let testi =  ['orava', 99, 'copic', 8, 9];

testi.push('tussi');
testi.push(10);
testi[0] = 3;*/


//union types
/*
let mixed: (string|number|boolean)[] = [];
mixed.push('tuut')
mixed.push(20);
mixed.push(false)
console.log(mixed);

let uid: string|number;
uid = '123';
uid = 123;*/

//objects
/*
let koira = {
    nimi: 'tiko',
    alias: 'ukko',
    ika: 13
};

koira.ika = 11;
koira.nimi = 'otto';

koira = {
    nimi: 'sisu',
    alias: 'rontti',
    ika: 5
}*/
/*
let ika: any = 25;
ika = true;
ika = 'Tervehdys';
console.log(ika);
ika = { nimi: 'taika }'};
console.log(ika);

let mixed: any[] = [];
mixed.push(5);
mixed.push('mario');
mixed.push(false);
console.log(mixed);

let ninja: { name: any, age: any };
ninja = {name: 'yoshi', age: 25 };
console.log(ninja);

ninja = { name: 25, age: 'yoshi'};
console.log(ninja);*/
/*
let greet: Function;
greet = () => {
    console.log('Hello world')
}
const add = (a: number, b: number, c: number|string = 10): void => {
    console.log(a + b);
    console.log(c);
}

add(5, 10, '20');

const minus = (a: number, b: number): number => {
    return a + b;
}

let result = minus(10, 7);*/

//let greet: Function;

//esimerkki 1
/*
let greet: (a: string, b: string) => void;
greet = (name: string, greeting: string) => {
    console.log('${name} says ${greeting}');
}
//esimerkki 2
let calc: (a: number, b: number, c: string ) => number;

calc = (numOne: number, numTwo: number, action: string) => {
    if (action === 'add') {
        return numOne + numTwo;
    }
    else {
        return numOne - numTwo;
    }
}

//esimerkki 3

let logDetails: (obj: {name: string, age: number}) => void;

type person = {name: string, age: number};

logDetails = (ninja: {name: string, age: number}) => {
    console.log(`${ninja.name} is ${ninja.age} years old`)
}*/

/*const anchor = document.querySelector('a')!;

console.log(anchor.href);*/

//const form = document.querySelector('.new-item-form') as HTMLFormElement;

//console.log(form.children);

//inputs
/*const type = document.querySelector('#type') as HTMLSelectElement;
const tofrom = document.querySelector('#tofrom') as HTMLInputElement;
const details = document.querySelector('#details') as HTMLInputElement;
const amount = document.querySelector('#amount') as HTMLInputElement;*/

/*form.addEventListener('submit', (e: Event) => {
    e.preventDefault();

    console.log(
        type.value
    )*/
/*
    if (form && type && tofrom && details && amount) {
    form.addEventListener('submit', (e: Event) => {
        e.preventDefault();
        console.log(type.value, tofrom.value, details.value, amount.value);
    });
} else {
    console.error('Yksi tai useampi elementti puuttuu!');
}


})*/

class Invoice {
    client: string;
    details: string;
    amount: number;

    constructor(c: string, d: string, a: number) {
        this.client = c;
        this.details = d;
        this.amount = a;
    }
    format() {
        return `${this.client} owes £${this.amount} for ${this.details}`
    }
}

const invOne = new Invoice('mario', 'work on mario website', 130);
const invTwo = new Invoice('luigi', 'work on luigi website', 456);

//console.log(invOne, invTwo);
let invoices: Invoice[] = [];
invoices.push(invOne);
invoices.push(invTwo);
console.log(invoices);