import {Food} from "./food";
export interface Species {
    id: number,
    name: string,
    appearance: string,
    adultAge: number,
    maxAge: number,
    foodID: number,
    diet: Food,
    sizeModifier: number
}