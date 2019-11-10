import React, { Component } from 'react';
import { Col, Container, Row } from 'react-bootstrap';
import { NavMenu } from './NavMenu';
import { FetchData } from './FetchData';
import { Home } from './Home';

export class Layout extends Component {
  displayName = Layout.name

  render() {
    return (
      <Container>
        <Row>
          <Col>
            <NavMenu />
          </Col>
        </Row>
        <Row>
          <Col sm={8}>
            <Home></Home>
          </Col>
          <Col sm={4}>
            <FetchData></FetchData>
          </Col>
        </Row>
      </Container>
    );
  }
}
