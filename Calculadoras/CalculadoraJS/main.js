const botoes = document.querySelectorAll("button");
const display = document.querySelector("#display");
const memoriaDisplay = document.querySelector("#memoria-display")
let operacao;
let funcDel;
let i = 0;
let numero = 0;
let numero2 = 0; 

botoes.forEach((bo)=>{
    bo.addEventListener('click',() => {
        if(bo.textContent === "C"){
            display.textContent = "0";
            memoriaDisplay.textContent = "0";
            numero = 0;
            numero2 = 0;
            return 0; 
        }
        else if(bo.textContent === "="){
            if(operacao === "+"){
                numero2 = parseInt(memoriaDisplay.textContent.replace(" +", ""))
                display.textContent = soma(numero, numero2)
                numero = parseInt(display.textContent);
                numero2 = 0;
                return 0;
            }
            else if(operacao === "-"){
                numero2 = parseInt(memoriaDisplay.textContent.replace(" -", ""))
                display.textContent = subtracao(numero, numero2)
                numero = parseInt(display.textContent);
                numero2 = 0;
                return 0;
            }
            else if(operacao === "x"){
                numero2 = parseInt(memoriaDisplay.textContent.replace(" x", ""))
                display.textContent = multiplicacao(numero, numero2)
                numero = parseInt(display.textContent);
                numero2 = 0;
                return 0;
            }
            else if(operacao === "/"){
                numero2 = parseInt(memoriaDisplay.textContent.replace(" /", ""))
                display.textContent = divisao(numero, numero2)
                numero = parseInt(display.textContent);
                numero2 = 0;
                return 0;
            }
            else{
                
                return 0;
            }
        }
        else if(bo.textContent === "+" 
                    || bo.textContent === "-" 
                    || bo.textContent === "x" 
                    || bo.textContent === "/"){
            memoriaDisplay.textContent = numero + " "+ bo.textContent
            operacao = bo.textContent;
            display.textContent = "0";
            
        }
        else if(bo.textContent === "CE"){
            display.textContent = "0";
            return 0;
        }
        else if(bo.textContent === "￩"){ 
            apagar();            
        }
        else if(display.textContent === "0"){
            display.textContent = bo.textContent
            numero = parseInt(display.textContent);
        }
        else{
            display.textContent += bo.textContent;
            numero = parseInt(display.textContent);
        }  
    })
})

function soma(numero1, numero2){
    return numero1+numero2;
}

function subtracao(numero1, numero2){
    return  numero2 - numero1;
}

function multiplicacao(numero1, numero2){
    return numero1 * numero2;
}

function divisao(numero1, numero2){
    return  numero2 / numero1;
}

function apagar(){
    i = 0;
    funcDel = display.textContent;
    if(funcDel.length === 1){
        display.textContent = "0"
        return 0;
    }
    display.textContent = "";
    while(i < funcDel.length-1){
        display.textContent += funcDel[i]
        i++;
        numero = parseInt(display.textContent);
    }
}