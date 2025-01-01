
function ticketSale(day, age) {
    if (age < 0 || age > 122) {
        console.log('Error!');
        return;
    }
    if (day === 'Weekday' && age <= 18) {
        console.log('12$');
    } else if (day === 'Weekday' && age <= 64) {
        console.log('18$');
    } else if (day === 'Weekday' && age <= 122) {
        console.log('12$');
    } else if (day === 'Weekend' && age <= 18) {
        console.log('15$');
    } else if (day === 'Weekend' && age <= 64) {
        console.log('20$');
    } else if (day === 'Weekend' && age <= 122) {
        console.log('15$');
    } else if (day === 'Holiday' && age <= 18) {
        console.log('5$');
    } else if (day === 'Holiday' && age <= 64) {
        console.log('12$');
    } else if (day === 'Holiday' && age <= 122) {
        console.log('10$');
    } else {
        console.log('Error!');
    }
}

ticketSale('Weekday', 15);    // Outputs: 12$
ticketSale('Weekend', 30);    // Outputs: 20$
ticketSale('Holiday', 70);    // Outputs: 10$
ticketSale('Random', 20);     // Outputs: Error!
ticketSale('Weekend', -5);    // Outputs: Error!

