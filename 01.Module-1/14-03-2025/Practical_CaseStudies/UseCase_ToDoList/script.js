function addTask() {
    const taskInput = document.getElementById('taskInput');
    const taskList = document.getElementById('taskList');

    if (taskInput.value.trim() === '') {
        alert('Please enter a task!');
        return;
    }

    const li = document.createElement('li');
    const taskText = document.createElement('span');
    taskText.textContent = taskInput.value;

    const deleteBtn = document.createElement('button');
    deleteBtn.textContent = 'Delete';
    deleteBtn.className = 'delete-btn';
    deleteBtn.onclick = function() {
        li.remove();
    };

    taskText.onclick = function() {
        taskText.classList.toggle('completed');
    };

    li.appendChild(taskText);
    li.appendChild(deleteBtn);
    taskList.appendChild(li);

    taskInput.value = '';
}

// Add ability to press Enter to add a task
document.getElementById('taskInput').addEventListener('keypress', function(e) {
    if (e.key === 'Enter') {
        addTask();
    }
});
