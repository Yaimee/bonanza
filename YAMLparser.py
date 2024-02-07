import yaml
from user import User

def read_users_from_yaml(filename):
    with open(filename, 'r') as file:
        data = yaml.safe_load(file)  # Load the YAML file data
        users = []
        for item in data['users']:  # Iterate over each user entry
            users.append(User(int(item['user_id']), item['name'], item['email']))
    return users

# Assuming the file name is "file2.yaml" and is in the correct path
users = read_users_from_yaml("file2.yaml")

for user in users:
    print(user.printUser())
