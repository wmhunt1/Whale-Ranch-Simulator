import {Toy} from "./toy"
export interface Personality {
    id: number,
    name: string,
    traits: string,
    favoriteToyID: number,
    favoriteToy: Toy
}