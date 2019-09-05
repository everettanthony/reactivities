import React from 'react';
import { Segment, Form, Button } from 'semantic-ui-react';
import { states } from '../../../common/states';
import './ActivityForm.css';

const ActivityForm = () => {
    return (
        <Segment>
            <Form id="activityForm">
                <Form.Input placeholder='Title' />
                <Form.TextArea rows={4} placeholder='Description' />
                <Form.Input placeholder='Category' />
                <Form.Input type='date' placeholder='Date' />
                <Form.Input placeholder='Venue' />
                <Form.Input placeholder='City' />
                <Form.Select options={states} placeholder='Selet a State' />
                <Form.Input placeholder='Zip' />
                <Form.Checkbox label='Is Active?' />
                <Button type='submit'>Submit</Button>
            </Form>
        </Segment>
    )
}

export default ActivityForm;
