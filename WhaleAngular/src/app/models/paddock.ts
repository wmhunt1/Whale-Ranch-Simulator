import {Food} from "./food"
import {Ranch} from "./ranch"
import {Toy} from "./toy"
import {Whale} from "./whale"


export interface Paddock {
    id: number,
    name: string,
    condition: number,
    currentOccupancy: number,
    maxOccupancy: number,
    trough: Food[],
    whales: Whale[],
    ranchID: number,
    ranch: Ranch,
    toyId: number,
    enrichment: Toy
}