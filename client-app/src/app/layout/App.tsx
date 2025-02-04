import React, { useState, useEffect, Fragment } from 'react';
import { Container } from 'semantic-ui-react';
import axios from 'axios';
import { IActivity } from '../models/activity';
import NavBar from '../../features/nav/NavBar';
import ActivityDashboard from '../../features/activities/dashboard/ActivityDashboard';

const App = () => {
  const [activities, setActivities] = useState<IActivity[]>([]);
  const [selectedActivity, setSelectedActivity] = useState<IActivity | null>(null);

  const handleSelectActivity = (id: string) => {
    setSelectedActivity(activities.filter(a => a.id === id)[0]);
  }

  useEffect(() => {
    axios.get<IActivity[]>('http://localhost:5000/api/activities')
      .then((rsp) => {
        setActivities(rsp.data)
      });
  }, []);

  return (
      <Fragment>
        <Container fluid>
          <NavBar />
          <Container style={{marginTop:'6em'}}>
            <ActivityDashboard 
              activities={activities} 
              selectActivity={handleSelectActivity} 
              selectedActivity={selectedActivity} />
          </Container>
        </Container>
      </Fragment>
    );
}

export default App;