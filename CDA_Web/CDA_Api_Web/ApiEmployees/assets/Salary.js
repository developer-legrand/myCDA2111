export class Salary {
    constructor(annuary) {
        this.annuary = annuary;
    }

    getMonthly()
    {
        return this.annuary / 12;
    }
}
