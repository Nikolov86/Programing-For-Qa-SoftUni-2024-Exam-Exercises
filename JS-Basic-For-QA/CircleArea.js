function calcCircleArea(radius){
    
    let typeInputParameter = typeof radius; // 'number' или нещо друго
    if (typeInputParameter === 'number'){
        let area = Math.PI *radius ** 2
        console.log(area.toFixed(2));
    }else{
        console.log(`We can not calculate the circle area, because we receive a ${typeInputParameter}`);
    }
}
calcCircleArea(5);
calcCircleArea('name');