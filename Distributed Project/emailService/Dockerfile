# Use an official Node.js runtime as a base image for your Node.js app
FROM node:14

# Copy package.json and package-lock.json to the working directory
COPY package*.json ./

# Install app dependencies
RUN npm install

# Copy the rest of the application code to the working directory
COPY . .

# Command to run your application
CMD ["npm", "start"]