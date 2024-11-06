class hero{
    constructor(name, age, heroType){
        this.name = name;
        this.age = age;
        this.heroType = heroType;
    }

    attack(){
        let arm = ''

        switch(this.heroType){
            case "mago":
                arm = "magia";
            break;

            case "guerreiro":
                arm = "espada";
            break;

            case "monge":
                arm = "artes marciais";
            break;
            
            case "ninja":
                arm = "shuriken";
            break;
        }

        console.log(`O ${this.heroType} atacou usando ${arm}`);
    }
}

//teste

const choose = new hero("Arthas", 30, "monge");

choose.attack();
