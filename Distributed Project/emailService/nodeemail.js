const nodemailer = require('nodemailer');
const kafka = require('kafka-node');

const transporter = nodemailer.createTransport({
    host: 'smtp.ethereal.email',
    port: 587,
    auth: {
        user: 'damien74@ethereal.email',
        pass: 'Pq9ZUK4wQVfyFh4Ax8',
    },
});

function sendEmail(to, subject, text) {
    const mailOptions = {
        from: 'your-email@gmail.com',
        to: to,
        subject: subject,
        text: text
    };

    transporter.sendMail(mailOptions, function (error, info) {
        if (error) {
            console.error('Error sending email:', error);
        } else {
            console.log('Email sent:', info.response);
        }
    });
}

module.exports = {
    sendEmail
};