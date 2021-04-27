import {Facility} from "./facility"
import {Paddock} from "./paddock"
import {Rancher} from "./rancher";
export interface Ranch {
    id: number
    name: string,
    rancherID: number,
    owner: Rancher,
    facilities: Facility[],
    paddocks: Paddock[]
}