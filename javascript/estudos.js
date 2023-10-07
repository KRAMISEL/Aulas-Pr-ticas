"use Strict"
let f = ""
function* Geradora(){
    const cor1 = yield 'A cor1 será vermelho'
    const cor2 = yield 'A cor2 será verde'
    const cor3 = yield 'A cor3 será azul'
    return 'Cor1: ' + cor1 + '\nCor2: ' + cor2 + '\nCor3: ' + cor3
}
let Função = F => {
    variável = "Olá Mundo"
    return variável
}
console.log(f = Função())
f = Geradora()
console.log(f.next().value)
console.log(f.next('vermelho').value)
console.log(f.next('verde').value)
console.log(f.next('azul').value)