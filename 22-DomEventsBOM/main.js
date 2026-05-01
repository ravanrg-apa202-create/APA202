
const card = document.createElement('div');
card.style.width = '300px'
card.style.padding = '20px'
card.style.margin = '50px auto'
card.style.backgroundColor = '#ffffff'
card.style.borderRadius = '12px'
card.style.boxShadow = '0 4px 8px rgba(0,0,0,0.1)'
card.style.fontFamily = 'Arial, sans-serif'
card.style.transition = 'transform 0.3s ease, box-shadow 0.3s ease'
card.style.textAlign = 'center'


card.addEventListener('mouseover', () => {
    card.style.transform = 'translateY(-10px)'
    card.style.boxShadow = '0 8px 16px rgba(0,0,0,0.2)'
})
card.addEventListener('mouseout', () => {
    card.style.transform = 'translateY(0)'
    card.style.boxShadow = '0 4px 8px rgba(0,0,0,0.1)'
})


const title = document.createElement('h2')
title.innerText = 'İnteraktiv Kart'
title.style.color = '#333'
title.style.fontSize = '22px'
title.style.marginBottom = '10px'

// 3. Mətn (Açıqlama) yaradırıq
const description = document.createElement('p');
description.innerText = 'Bu kart tamamilə JavaScript ilə yaradilib, stilləndirilib və interaktiv elementlərlə təchiz edilib.'
description.style.color = '#666'
description.style.fontSize = '14px'
description.style.lineHeight = '1.6'
description.style.marginBottom = '25px'


const button = document.createElement('button')
button.innerText = 'Daha Çox'
button.style.padding = '10px 20px'
button.style.backgroundColor = '#007BFF'
button.style.color = 'white'
button.style.border = 'none'
button.style.borderRadius = '6px'
button.style.cursor = 'pointer'
button.style.fontSize = '16px'
button.style.fontWeight = 'bold'
button.style.transition = 'background-color 0.3s ease, transform 0.1s ease'


button.addEventListener('mouseover', () => {
    button.style.backgroundColor = '#0056b3'
})
button.addEventListener('mouseout', () => {
    button.style.backgroundColor = '#007BFF'
})
button.addEventListener('mousedown', () => {
    button.style.transform = 'scale(0.95)'
})
button.addEventListener('mouseup', () => {
    button.style.transform = 'scale(1)'
})
button.addEventListener('click', () => {
    button.innerText = 'Təsdiqləndi ✅'
    button.style.backgroundColor = '#28a745'
})


card.appendChild(title)
card.appendChild(description)
card.appendChild(button)


document.body.style.backgroundColor = '#f4f7f6'
document.body.style.display = 'flex'
document.body.style.justifyContent = 'center'
document.body.style.alignItems = 'center'
document.body.style.minHeight = '100vh'
document.body.style.margin = '0'

document.body.appendChild(card)