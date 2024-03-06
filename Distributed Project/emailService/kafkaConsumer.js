const kafka = require('kafka-node');
const nodemailer = require('nodemailer');
//const { sendEmail } = require('../emailService/nodeemail');
const Consumer = kafka.Consumer;
const client = new kafka.KafkaClient({ kafkaHost: 'kafka:9092' });


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
        to: 'damien74@ethereal.email',
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


var topicsToCreate = [{
    topic: 'password-change-topic',
    partitions: 1,
    replicationFactor: 1
  },
  {
    topic: 'offer-topic',
    partitions: 1,
    replicationFactor: 1
  }
]

client.createTopics(topicsToCreate, (error, result) => {
    console.log(error);
    const consumer = new Consumer(
        client,
        [{ topic: 'password-change-topic' }, { topic: 'offer-topic' }],
        //{ groupId: 'email-notifications-group' }
    );
    
    consumer.on('message', function (message) {
        const payload = JSON.parse(message.value);
        console.log(payload);

        const to = 'damien74@ethereal.email';
        const subject = "Kafka Notification";
        const text = `User ID: ${payload.userId}\nAction: ${payload.action}`
        
        if(message.topic ==='password-change-topic'){
        sendEmail(to, subject, text);

        }else if(message.topic === 'offer-topic'){
            sendEmail(to, subject, text);

        }
      
    })
  
    consumer.on('error', function (err) {
        console.error('Kafka consumer error:', err);
    });
    
  });
  


