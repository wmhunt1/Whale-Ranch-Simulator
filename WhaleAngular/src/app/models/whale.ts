import {Personality} from "./personality"
import {Species} from "./species"
export interface Whale {
    id: number,
    name: string,
    happiness: number,
    health: number,
    hunger: number,
    personalityID: number,
    personality: Personality,
    speciesId: number,
    species: Species,
    age: number,
    length: number,
    width: number,
    sex: string

}