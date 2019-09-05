import React, { Fragment } from 'react';
import { Card, Button, Label } from 'semantic-ui-react';
import { IActivity } from '../../../app/models/activity';

interface IProps {
    activities: IActivity[],
    selectActivity: (id: string) => void;
}

const ActivityList: React.FC<IProps> = ({activities, selectActivity}) => {
    return (
        <Fragment>
            <Card.Group>
                { activities.map((activity) => (
                    <Card key={activity.id} style={{width:'100%'}}>
                        <Card.Content>
                            <Card.Header as='a'>{activity.title}</Card.Header>
                            <Card.Meta>{activity.dateFormatted}</Card.Meta>
                            <Card.Description>
                                <div>{activity.description}</div>
                                <div>{activity.city}, {activity.state} {activity.zip}</div>
                                <div>{activity.venue}</div>
                            </Card.Description>
                        </Card.Content>
                        <Card.Content extra>
                                <Button 
                                    onClick={() => selectActivity(activity.id)} 
                                    floated='right' 
                                    content='View' 
                                    color='blue' />
                                <Label basic content={activity.category} />
                        </Card.Content>
                    </Card>
                ))}

            </Card.Group>
        </Fragment>
    )
}

export default ActivityList;
