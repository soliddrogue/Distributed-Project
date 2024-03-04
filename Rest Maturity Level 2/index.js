const express = require('express');
const bodyParser = require('body-parser');
const app = express();
const port = 8080;

app.use(bodyParser.json());



let ideas = [
  { id: 1, title: 'Idea 1', description: 'Great Idea' },
  { id: 2, title: 'Idea 2', description: 'Sike this idea is better' }
];

app.get('/ideas', (req, res) => {
  res.json(ideas);
});


app.post('/ideas', (req, res) => {
  const idea = req.body;
  idea.id = ideas.length + 1;
  ideas.push(idea);
  res.status(201).json(idea);
});



app.patch('/ideas/:id', (req, res) => {
  const ideaId = parseInt(req.params.id);
  const updatedProperties = req.body;

  ideas = ideas.map((idea) => {
    if (idea.id === ideaId) {
      return { ...idea, ...updatedProperties };
    } else {
      return idea;
    }
  });

  res.json(ideas.find((idea) => idea.id === ideaId));
});


app.put('/ideas/:id', (req, res) => {
    const ideaId = parseInt(req.params.id);
    const updateIdea = req.body;
  
    ideas = ideas.map((idea) => (idea.id === ideaId ? updateIdea : idea));
  
    res.json(updateIdea);
  });


app.delete('/ideas/:id', (req, res) => {
  const ideaId = parseInt(req.params.id);
  ideas = ideas.filter((idea) => idea.id !== ideaId);
  res.sendStatus(204);
});


app.listen(port, () => {
  console.log(`Server is running on port ${port}`);
});