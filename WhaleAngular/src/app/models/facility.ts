import {Ranch} from "./ranch";
export interface Facility {
    id: number,
    name: string,
    ranchId: number,
    ranch: Ranch
    description: string
}