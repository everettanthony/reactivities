let data = 42;

export interface ICar {
    color: string,
    model: string,
    topSpeed?: number
}

const car1: ICar = {
    color: 'blue',
    model: 'BMW',
    topSpeed: 90
}

const car2: ICar = {
    color: 'red',
    model: 'Mercedes',
    topSpeed: 100
}

const car3: ICar = {
    color: 'green',
    model: 'Pinto',
    topSpeed: 35
}

const car4: ICar = {
    color: 'black',
    model: 'Porsche',
    topSpeed: 150
}

const multiply = (x: number, y: number) => {
    return x * y;
}

export const cars = [car1, car2, car3, car4];